package example;

import com.amazonaws.services.lambda.runtime.Context;
import com.amazonaws.services.lambda.runtime.RequestHandler;
import com.sun.xml.internal.ws.api.message.ExceptionHasMessage;
import org.apache.kafka.clients.producer.KafkaProducer;
import org.apache.kafka.clients.producer.ProducerRecord;

import java.util.Map;
import java.util.Properties;

public class LambdaJavaAPI implements RequestHandler<Map<String, String>, GatewayResponse> {
    public GatewayResponse handleRequest(Map<String, String> event, Context context) {

        try {
            String cnpj = event.get("cnpj");

            Properties props = new Properties();
            props.put("bootstrap.servers", "######:9092");
            props.put("acks", "all");
            props.put("retries", 0);
            props.put("batch.size", 16384);
            props.put("linger.ms", 1);
            props.put("buffer.memory", 33554432);
            props.put("key.serializer", "org.apache.kafka.common.serialization.StringSerializer");
            props.put("value.serializer", "org.apache.kafka.common.serialization.StringSerializer");

            KafkaProducer<String, String> producer = new KafkaProducer<String, String>(props);
            producer.send(new ProducerRecord<String, String>("device", "cnpj", cnpj));
            producer.close();

            GatewayResponse response = new GatewayResponse(
                    200,
                    cnpj
            );
            return response;
        } catch (ExceptionHasMessage e) {
            GatewayResponse response = new GatewayResponse(
                    404,
                    e.toString()
            );
            return response;
        } catch (NullPointerException e){
            GatewayResponse response = new GatewayResponse(
                    404,
                    e.toString()
            );
            return response;
        }
    }
}