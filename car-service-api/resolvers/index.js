import { appointmentsResolvers } from "./appointmentsResolvers.js";
import { usersResolvers } from "./usersResolvers.js";
  
  
  export const resolvers = {
    Query: {
      ...appointmentsResolvers.Query,
      ...usersResolvers.Query,
    },
    Mutation: {
      ...usersResolvers.Mutation,
      ...appointmentsResolvers.Mutation,
    },
  };