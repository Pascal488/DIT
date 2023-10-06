import { mongoose } from "mongoose";
import bcrypt from 'bcrypt';

const SALT_ROUNDS = 10;
const userSchema = new mongoose.Schema({
  firtsName: {
    type: String,
    required: true,
  },
  lastName: {
    type: String,
    required: true,
  },
  phone: {
    type: String,
    required: true,
  },
  email: {
    type: String,
    required: true,
    unique: true,
  },
  password: {
    type: String,
    required: true,
  },
  token: {
    type: String, 
    required: false,
  }
});

userSchema.methods.comparePassword = async function (password) {
    return bcrypt.compare(password, this.password);
  };
  
  userSchema.pre('save', async function (next) {
    if (this.isModified('password')) {
      this.password = await bcrypt.hash(this.password, SALT_ROUNDS);
    }
    next();
  });

export const User = mongoose.model('User', userSchema);


