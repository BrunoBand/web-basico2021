import React from 'react'
import { NavigationContainer } from '@react-navigation/native'
import { createStackNavigator } from '@react-navigation/stack'
import UserList from './view/UserList'
import UserForm from './view/UserForm'

const Stack = createStackNavigator()

export default function (props) {
  return (
    <NavigationContainer>
      <Stack.Navigator
        initialRouteName="UserList"
        screenOptions={screenOptions}>
        <Stack.Screen
          name="UserList"
          component={UserList}
          options={{
            title: "Usuarios"
          }}
        />
        <Stack.Screen
          name="UserForm"
          component={UserForm}
          options={{
            title: "Formulario"
          }}
        />
      </Stack.Navigator>
    </NavigationContainer>
  )
}

const screenOptions = {
  headerStyle: {
    backgroundColor: '#4169E1'
  },
  headerTintColor: '#D3D3D3',
  headerTitleStyle: {
    fontWeight: 'bold'
  }
}