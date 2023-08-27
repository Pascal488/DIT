import {gql} from "@apollo/client"


export const REGISTER = gql `
mutation CreateUser($input: UserInput!) {
    createUser(input: $input) {
      id
      firstName
      lastName
      email
      phone
      token
      location
      password
    }
  }

`

export const BOOKING = gql`
mutation CreateAppointment($date: String!, $name: String!, $descriptions: String!, $services: String!, $email: String!, $phonenumber: String!, $location: String!, $time: String!) {
  createAppointment(date: $date, name: $name, descriptions: $descriptions, services: $services, email: $email, phonenumber: $phonenumber, location: $location, time: $time) {
    id
    date
    name
    descriptions
    services
    email
    phonenumber
    location
    time
  }
}



`