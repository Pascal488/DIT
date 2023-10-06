import { User } from "../models/user.js";

export const usersResolvers = {
Query: {
    getUser: async (_, { id }) => {
      const user = await User.findById(id);
      return user;
    },
    getUsers: async () => {
        const users = await User.find({});
        return users;
      }
  },
  Mutation: {
    createUser: async (_, { input }) => {
      const user = await User(input);
      await user.save();
      return user;
    },
    updateUser: async (_, { id, input }) => {
      const user = await User.findByIdAndUpdate(id, input, { new: true });
      return user;
    },
    deleteUser: async (_, { id }) => {
      await User.findByIdAndDelete(id);
      return id;
    },
    login: async (_, { email, password }) => {
      const user = await User.findOne({ email });
      if (!user) {
        throw new Error('User not found');
      }
      if (user.password !== password) {
        throw new Error('Invalid password');
      }
      return 'some-jwt-token'; 
    }
  }}
