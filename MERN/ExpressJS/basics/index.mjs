// const express = require('express')
import express from 'express';
import path from 'path';
const app = express()
const port = 3000
const dirname = path.resolve();

app.use(express.json());

app.get('/', (req, res) => {
  res.send('Hello World!')
})

// app.get('/contact', (req, res) => {
//   res.send('Hello from Contact Page!')
// })

app.get('/image', (req, res) => {
  res.sendFile(dirname + '/static/Citiguide.PNG')
})

app.use('/home', express.static(dirname, {index: '/static/index.html'}));

// Router Parameter (They are compulsory)
app.get('/product/:id', (req, res) => {
  res.json({name: "Product No " + req.params.id})
})

app.get('/posts/:id', (req, res) => {
  let postId = req.params.id;
  let postObj = [
    {
    id: 1,
    title: "Exploring Node.js",
    content: "Learn how to build scalable backend applications using Node.js.",
    author: "Owais Ahmed",
    date: "2025-10-18"
  },
  {
    id: 2,
    title: "Frontend Tips",
    content: "Best practices for creating responsive designs with CSS Grid and Flexbox.",
    author: "Ammad Khan",
    date: "2025-10-17"
  },
  {
    id: 3,
    title: "MongoDB Aggregation",
    content: "A deep dive into MongoDB aggregation pipelines for data analysis.",
    author: "Ali Raza",
    date: "2025-10-16"
  },
  {
    id: 4,
    title: "API Security Basics",
    content: "Learn about authentication, authorization, and securing REST APIs.",
    author: "Zain Ahmed",
    date: "2025-10-15"
  }
  ]

  postObj.map((post) => {
    if(post.postId == postId){
      console.log(post);
      postObj =post
    }
  })

  res.send(postObj);
  // res.json({name: "Product No " + req.params.id})
})

//Query Paramater (They are optional)
app.get('/categories', (req, res) => {
  if(req.query.name){
    res.json({name: "Category " + req.query.name})
  }
  else{
    res.json({name: "All Categories "})
  }
})

// Req Body (They are used to send data to server)

app.post('/contact', (req, res) => {
  // const name = req.body.name;
  // const email = req.body.email;
  // const message = req.body.message;

  // destructing
  const {name, email, message} = req.body;

  res.json({name: name, email: email, message: message})
})




app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
