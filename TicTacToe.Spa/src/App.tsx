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

  const { start, playMove } = useApi("https://localhost:5001");

  const handleStart = async (name: string) => {
    setOpen(false);

    const game = await start(name);

    setGame(game);
  };

  const handleCellClick = (cellId: number) => async () => {
    const { cell, value } = await playMove(game?.id as string, cellId);

    setGame((g) => {
      const n = { ...g };

      Object.keys(n).forEach((key) => {
        if (`cell${cellId}` === key) n[key as keyof Game] = "X";
        if (`cell${cell}` === key) n[key as keyof Game] = value;
      });

      return { ...n } as Game;
    });
  };

  return (
    <>
      <div className={classes.root}>
        {Object.keys(game || {})
          .filter((key) => key.includes("cell"))
          .map((key) => {
            const id = parseInt(key.replace("cell", ""));
            const value = game ? game[key as keyof Game] : "";

            return (
              <Cell
                key={id}
                id={id}
                value={value}
                onClick={handleCellClick(id)}
              />
            );
          })}
      </div>
      <Menu open={open} onNewGame={handleStart} />
    </>
  );
};

export default App;
