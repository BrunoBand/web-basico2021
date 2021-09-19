import React from 'react'
import { View, FlatList } from 'react-native'
import users from '../data/Users'
import { ListItem, Avatar } from 'react-native-elements'

export default function (props) {

    function getUserItem({ item }) {
        return (
            <ListItem
                key={item.id.toString()}
                bottomDivider
                onPress={() => props.navigation.navigate("UserForm", item)}
            >
                <Avatar source={{ uri: item.avatarUrl }} />
                <ListItem.Content>
                    <ListItem.Title>{item.name}</ListItem.Title>
                    <ListItem.Subtitle>{item.email}</ListItem.Subtitle>
                </ListItem.Content>
            </ListItem>
        )
    }



    return (
        <View>
            <FlatList
                keyExtractor={user => user.id.toString()}
                data={users}
                renderItem={getUserItem}
            />
        </View>
    )
}
