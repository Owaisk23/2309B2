import 'package:flutter/material.dart';

class UserProfile extends StatefulWidget {
  const UserProfile({ Key? key }) : super(key: key);

  @override
  _UserProfileState createState() => _UserProfileState();
}

class _UserProfileState extends State<UserProfile> {
  var user = {"userName": "Owais Ahmed", "userAge": 25, "userDesignation": "Software Developer"};


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        // Sting Interpolation
        title: Text('${user['userName']}\'s Profile'),
        // Owais Ahmed's Profile
        backgroundColor: Colors.black,
        foregroundColor: Colors.white,
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          children: [
            Text("User Detail's", style: TextStyle(fontSize: 30, fontWeight: FontWeight.bold)),
            SizedBox(height: 20),
            Image.network('https://avatars.githubusercontent.com/u/57331778?v=4',
              height: 200,
              width: 200,
              fit: BoxFit.cover,
            ),
            Text("Name: ${user['userName']}"),
            Text("Age: ${user['userAge']}"),
            Text("Designation: ${user['userDesignation']}"),
            SizedBox(height: 20),
            ElevatedButton(
              onPressed: (){
                print("User name before change: ${user['userName']}");
                setState(() {
                  user['userName'] = "Ashar Ahmed";
                });
                print("User name after change: ${user['userName']}");
              },
              child: Text("Change Profile Name"),
            )

          ],
        ),
      ),
    );
  }
}