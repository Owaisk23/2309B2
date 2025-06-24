import 'package:firstproject/Screens/boxlistView.dart';
import 'package:firstproject/Screens/darazScreen.dart';
import 'package:firstproject/Screens/dynamicList.dart';
import 'package:firstproject/Screens/firstScreen.dart';
import 'package:firstproject/Screens/product.dart';
import 'package:firstproject/Screens/signup.dart';

import 'package:firstproject/Screens/userProfile.dart';
import 'package:flutter/material.dart';

class DrawerSide extends StatefulWidget {
  const DrawerSide({ Key? key }) : super(key: key);

  @override
  _DrawerSideState createState() => _DrawerSideState();
}

class _DrawerSideState extends State<DrawerSide> {
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        padding: EdgeInsets.zero,
        children: [
          DrawerHeader(
            decoration: BoxDecoration(
              color: Colors.blue,
            ),
            child: Text(
              'Side Menu',
              style: TextStyle(
                color: Colors.white,
                fontSize: 24,
              ),
            ),
          ),
          ListTile(
            leading: Icon(Icons.home),
            title: Text('Product'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => Product()));
            },
          ),
          ListTile(
            leading: Icon(Icons.phone),
            title: Text('First Screen'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => FirstScreen()));
            },
          ),
          ListTile(
            leading: Icon(Icons.add_box),
            title: Text('Box List'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => BoxlistView()));
            },
          ),
          ListTile(
            leading: Icon(Icons.verified_user),
            title: Text('User Profile'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => UserProfile()));
            },
          ),
          ListTile(
            leading: Icon(Icons.list),
            title: Text('Dynamic List'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => DynamicList()));
            },
          ),
          ListTile(
            leading: Icon(Icons.list),
            title: Text('Daraz Screen'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => DarazScreen()));
            },
          ),
          ListTile(
            leading: Icon(Icons.list),
            title: Text('SignUp Screen'),
            onTap: () {
              Navigator.push(context, MaterialPageRoute(builder: (context) => Signup()));
            },
          ),
          
        ],
      ),
    );
  }
}