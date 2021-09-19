import React, { useState } from 'react'
import { Text, TextInput, View, StyleSheet, Button, Alert } from 'react-native'

export default function (props) {

    const [user, setUser] = useState(props.route.params ? props.route.params : {})

    function confirmUserDeletion(user) {
        Alert.alert('Excluir usuario', 'Você tem certeza que deseja remover o usuário?', [
            {
                text: 'Sim',
                onPress() {
                    console.warn('delete ' + user.id)
                }
            },
            {
                text: 'Nao'
            }
        ])
    }
    return (
        <View style={styles.form}>
            <Text>Nome:</Text>
            <TextInput
                onChangeText={name => setUser({ ...user, name })}
                placeholder="Informe o Nome"
                value={user.name}
                style={styles.input}
            />
            <Text>Email:</Text>
            <TextInput
                onChangeText={email => setUser({ ...user, email })}
                placeholder="Informe o email"
                value={user.email}
                style={styles.input}
            />
            <Text>Url do avatar:</Text>
            <TextInput
                onChangeText={avatarUrl => setUser({ ...user, avatarUrl })}
                placeholder="Informe a url do avatar"
                value={user.avatarUrl}
                style={styles.input}
            />
            <View style={styles.buttons}>
                <Button title="Salvar" onPress={() => { props.navigation.goBack() }} />
                <Button title="Remover" onPress={() => confirmUserDeletion(user)} />
                <Button title="Cancelar" />
            </View>

        </View>
    )
}

const styles = StyleSheet.create({
    form: {
        padding: 12
    },
    input: {
        height: 40,
        borderColor: 'gray',
        borderWidth: 1,
        marginBottom: 10
    },
    buttons: {
        flexDirection: 'row',
        justifyContent: 'space-around'
    }
})
