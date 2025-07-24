// import 'package:crud/addproduct.dart';
import 'package:crud/firebase_options.dart';
import 'package:crud/products.dart';
import 'package:crud/signup.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/material.dart';

void main()async {

  await Firebase.initializeApp(
  options: DefaultFirebaseOptions.currentPlatform,
);
  runApp(
    MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Signup(),
    )
  );
}