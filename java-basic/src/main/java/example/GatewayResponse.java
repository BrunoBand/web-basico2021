package example;

import java.util.Map;

public class GatewayResponse {

    private Integer statusCode;
    private String cpnj;

    public GatewayResponse(Integer statusCode, String cpnj) {
        this.statusCode = statusCode;
        this.cpnj = cpnj;
    }

    public Integer getStatusCode() {
        return statusCode;
    }

    public void setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
    }

    public String getCpnj() {
        return cpnj;
    }

    public void setCpnj(String cpnj) {
        this.cpnj = cpnj;
    }
}