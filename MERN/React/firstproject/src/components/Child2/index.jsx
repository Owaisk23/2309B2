import React from "react";

const Child2 = ({ games }) => {
  return (
    <div>
      {games.map((game, index) => {
        return <h2 key={index}>{game}</h2>;
      })}
    </div>
  );
};

export default Child2;
