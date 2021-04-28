import { useState } from "react";

const Cell = () => {
  const [value, setValue] = useState<string | null>(null);

  const handleClick = () => {
    setValue((v) => (v === "X" ? "O" : "X"));
  };

  return (
    <div
      style={{
        display: "flex",
        width: 150,
        height: 150,
        padding: 16,
        backgroundColor: "#dfe6e94a",
        margin: 4,
        borderRadius: 4,
        justifyContent: "center",
        alignItems: "center",
        fontSize: "72pt",
        fontFamily: "Sans-Serif",
        color: value === "X" ? "#16a085" : "#2980b9",
        cursor: "pointer",
        userSelect: "none",
      }}
      onClick={handleClick}
    >
      {value}
    </div>
  );
};

export default Cell;
