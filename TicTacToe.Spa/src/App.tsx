import { useState } from "react";
import Cell from "./components/Cell/Cell";
import Menu from "./components/Menu/Menu";
import useApi from "./hooks/useApi";
import Game from "./interfaces/Game";
import useStyles from "./App.styles";

const App = () => {
  const classes = useStyles();

  const [game, setGame] = useState<Game | null>(null);
  const [open, setOpen] = useState(true);

  const { start } = useApi("https://localhost:5001");

  const cells = new Array(9).fill(0).map((_, i) => ({ index: i, value: null }));

  const handleStart = async (name: string) => {
    setOpen(false);

    const game = await start(name);

    setGame(game);
  };

  return (
    <>
      <div className={classes.root}>
        {cells.map((c) => (
          <Cell key={c.index} id={c.index + 1} />
        ))}
      </div>
      <Menu open={open} onNewGame={handleStart} />
    </>
  );
};

export default App;
