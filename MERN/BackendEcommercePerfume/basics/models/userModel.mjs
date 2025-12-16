import mongoose from 'mongoose';
const { Schema } = mongoose;

const userSchema = new Schema({
  username: {type: String, required: [true, "Username is required"]}, // String is shorthand for {type: String}
  email: {type: String, RegExp: /.+\@.+\..+/, required: [true, "Email is required"]},
  password: {type: String, required: [true, "Password is required"]},
  profilePicture: {type: String},
  role: {type: String, default: "user"},
  isVerified: {type: Boolean, default: false},
  isActive: {type: Boolean, default: true}
});

const User = mongoose.model('User', userSchema);

export default User;