export const typeDefs = `#graphql

type User {
  id: ID!
  firstName: String!
  lastName: String!
  email: String!
  phone: String!
  token: String
  location:String!
  password: String!

}
input UserInput {
  firstName: String!
  lastName: String!
  email: String!
  phone: String!
}



type Appointment {
  id: ID!
  date:String!
  name:String!
  descriptions:String!
  services:String!
  email:String!
  phonenumber:String!
  location: String!
  time:String!
}

type Query {
  getUser(id: ID!): User!
  getUsers: [User!]!
  appointments: [Appointment]!
}

type Mutation {
   createUser(input: UserInput!): User!
   login(email: String!, password: String!): User!
    updateUser(id: ID!, input: UserInput!): User!
  deleteUser(id: ID!): ID!
  createAppointment(
    date:String!
    name:String!
    descriptions:String!
    services:String!
    email:String!
    phonenumber:String!
    location: String!
    time:String!
  ): Appointment
}

`;