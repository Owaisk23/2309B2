import 'package:flutter/material.dart';
import 'package:firstproject/Screens/drawerSide.dart' as drawerSide;

class DynamicList extends StatefulWidget {
  const DynamicList({ Key? key }) : super(key: key);

  @override
  _DynamicListState createState() => _DynamicListState();
}

class _DynamicListState extends State<DynamicList> {
  final users = [
    {
      'id': 1,
      'name': 'Munna Bhai',
    },
    {
      'id': 2,
      'name': 'Altaf Bhai',
    },
    {
      'id': 3,
      'name': 'Jeetha Bhai',
    },
    {
      'id': 4,
      'name': 'Hathi Bhai',
    },
    {
      'id': 5,
      'name': 'Sallu Bhai',
    },
    {
      'id': 6,
      'name': 'Amir Bhai',
    },
    {
      'id': 7,
      'name': 'General Asim Munir',
    },
  ];


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Contact List'),
        backgroundColor: Colors.black,
        foregroundColor: Colors.white,
        centerTitle: true,
      ),
      drawer: drawerSide.DrawerSide(),
      body: ListView.builder(
        itemCount: users.length,
        itemBuilder: (context, index){
          return ListTile(
            title: Text('${users[index]['name']}' ?? 'No Name'),
            subtitle: Text('This is Bhai Users'),
            leading: Icon(Icons.person, color: Colors.blue, size: 40),
            trailing: Icon(Icons.phone, color: Colors.grey, size: 20),
          );
        }),
    );
  }
}