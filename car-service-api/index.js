import { ApolloServer } from '@apollo/server';
import { startStandaloneServer } from '@apollo/server/standalone';
import { resolvers } from './resolvers/index.js';
import { typeDefs } from './schemas/index.js';
import { connect } from 'mongoose';
import { MONGODB } from './config.js';

const server = new ApolloServer({
  typeDefs,
  resolvers,
});

await connect(MONGODB, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});
console.log('MongoDB connected successfully');

const { url } = await startStandaloneServer(server, {
  listen: { port: 4000 },
});

console.log(`🚀  Server ready at: ${url}`);
