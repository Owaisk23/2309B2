import User from '../models/userModel.mjs'
import bcrypt from "bcrypt";
import jwt from "jsonwebtoken";

// Fetching data from database
let index = async (req, res) => {
  try {
    const users = await User.find();
    if(users.length > 0){
      res.status(200).json({ message: "Users found", users: users });
    } else {
      res.status(404).json({ message: "No User found" });
    }
  } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}

let Signup = async(req, res) => {
    try{
        const {username, email, password} = req.body;
        let checkUser = await User.findOne({email:email});
        if(checkUser){
            res.status(200).json({message: "user already exist from this email, Please login...!"})
        }else{
            // hash password
            const hashPassword = bcrypt.hashSync(password, 10);
            console.log(hashPassword)

            let newUser = new User({
                username,
                email,
                password: hashPassword,
            })

            let adduser = await newUser.save();
            if(adduser){
                res.status(200).json({message: "Registration is successfully completed.", user:adduser });
            } else{
                res.status(500).json({message: "Failed to register user"})
            }
        }
    } catch (error) {
    console.log(error);
    res.status(500).json({ message: error.message })
  }
}


const userController = {
    index,
    Signup
}

export default userController;