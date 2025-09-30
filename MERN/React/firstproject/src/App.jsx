
import MyName from "./components/MyName";
import Navbar from "./components/Navbar";
import carImg from "./assets/porshe.jpg"
import { useState } from "react";
import Bulb from "./components/Bulb";
import Todo from "./components/Todo";

function App() {

  let userData = [
    { name: "Ashar", profession: "FrontEnd Developer" },
    { name: "Luqman", profession: "Flutter Developer" },
    { name: "Ayan Shakeel", profession: "Backend Developer" },
    { name: "Abdullah", profession: "UIUX Designer" },
    { name: "Hussain", profession: "UIUX Designer" },
    { name: "Usman", profession: "UIUX Designer" },
    { name: "Kharadar", profession: "UIUX Designer" },
    { name: "Moin", profession: "UIUX Designer" },
  ]

  // let count = 0;

  // function handleIncrement() {
  //   count++;
  //   console.log("Incremented:", count);
  // }

  //useState Hook
  //1.Import useState
  //2.Declare a state variable
  //3.Use the state variable in the component
  //4.Update the state variable using the setter function

  // const [count, setCount] = useState(0);

  // const [user, setUser] = useState({ name: "Ashar", profession: "FrontEnd Developer" });
  
  const [std, setStd]  = useState(["Ashar", "Luqman", "Ayan Shakeel"]);


  // const handleIncrement = () => {
  //   // count++;
  //   setCount(count + 1);
  //   console.log("Incremented:", count+1);
  // }

  const handleUserUpdate = () => {
    // setUser({ name: "Luqman", profession: "Flutter Developer" });

    setStd([...std, "Huzaifa"]);
    console.log("User Updated:", std);
  }

  return (

    console.log("App component rendered"),

    <>
      <Navbar />
      <h1 className="heading">Hello, in React App!</h1>
      {/* <h2>{userData[1].name} {userData[1].profession}</h2>
      <h2>{userData[3].name} {userData[3].profession}</h2> */}
      {/* <MyName name="Ashar" profession="FrontEnd Developer"/>
      <MyName name="Luqman" profession="Flutter Developer"/> */}

      {/* {
        userData.map((data, index) => {
          return <MyName key={index} name={data.name} profession={data.profession} />
        })
      }
     */}

      {/* <img src={carImg} alt="" width={300} height={200} /> */}
      {/* <h1>{count}</h1>
      <button className="btn btn-primary" onClick={handleIncrement}>Increment</button> */}
      {/* <h1>Name: {user.name} Profession: {user.profession}</h1> */}
      <h1>Students List:</h1>
      {
        std.map((student, index) => {
          return <h2 key={index}>{index + 1}. {student}</h2>
        })
      }
      <button className="btn btn-primary" onClick={handleUserUpdate}>Update User</button>

      <Bulb />

      <Todo />
    </>
  );
}

export default App;
