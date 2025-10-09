import React from "react";

const Child1 = ({ games, setgames }) => {
  let addGame = () => {
    let newgame = document.getElementById("newgame").value;
    setgames([...games, newgame]);
    console.log(games);
  };

  return (
    <div>
      <input type="text" placeholder="Enter a game" id="newgame" />
      <button className="btn btn-primary" onClick={addGame}>
        Add Game
      </button>
    </div>
  );
};

export default Child1;
