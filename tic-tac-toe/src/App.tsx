import { useState } from "react";
import Cell from "./components/Cell/Cell";
import Menu from "./components/Menu/Menu";
import useApi from "./hooks/useApi";

const App = () => {
  const [open, setOpen] = useState(true);
  const { start } = useApi();

  const cells = new Array(9).fill(0).map((_, i) => ({ index: i, value: null }));

  const handleStart = (name: string) => {
    setOpen(false);

    start(name);
  };

  return (
    <>
      <div
        style={{
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
          maxWidth: 600,
          margin: "0 auto",
          flexWrap: "wrap",
        }}
      >
        {cells.map((c) => (
          <Cell key={c.index} id={c.index + 1} />
        ))}
      </div>
      <Menu open={open} onNewGame={handleStart} />
    </>
  );
};

export default App;
