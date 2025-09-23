
import MyName from "./components/MyName";
import Navbar from "./components/Navbar";

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

  return (

    console.log("App component rendered"),

    <>
      <Navbar />
      <h1>Hello, in React App!</h1>
      {/* <h2>{userData[1].name} {userData[1].profession}</h2>
      <h2>{userData[3].name} {userData[3].profession}</h2> */}
      {/* <MyName name="Ashar" profession="FrontEnd Developer"/>
      <MyName name="Luqman" profession="Flutter Developer"/> */}

      {
        userData.map((data, index) => {
          return <MyName key={index} name={data.name} profession={data.profession} />
        })
      }
    
    </>
  );
}

export default App;
