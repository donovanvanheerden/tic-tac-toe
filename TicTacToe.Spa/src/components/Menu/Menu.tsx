import { Button, Dialog, TextField } from "@material-ui/core";
import { KeyboardEvent, useEffect, useRef, useState } from "react";
import useStyles from "./Menu.styles";
interface Props {
  open: boolean;
  onNewGame: (name: string) => void;
}

const Menu = ({ open, onNewGame }: Props) => {
  const classes = useStyles();
  const [showForm, setShowForm] = useState(false);

  const nameRef = useRef<HTMLInputElement>();

  useEffect(() => {
    if (showForm && nameRef.current)
      setTimeout(() => nameRef.current!.focus(), 200);
  }, [showForm]);

  const handleEnterPress = (e: KeyboardEvent<HTMLInputElement>) => {
    if (e.key === "Enter") handleStart();
  };

  const handleStart = () => {
    if (!nameRef.current) return;

    const name = nameRef.current.value.trim();

    if (!name) {
      console.log("no name");

      nameRef.current.focus();
    }

    onNewGame(name);
  };

  const Form = () => (
    <>
      <TextField
        fullWidth
        className={classes.textfield}
        placeholder="Player Name"
        onKeyPress={handleEnterPress}
        inputRef={nameRef}
        variant="outlined"
        color="secondary"
      />
      <div className={classes.formActions}>
        <Button
          onClick={() => setShowForm(false)}
          disableElevation
          variant="contained"
          color="default"
        >
          Cancel
        </Button>
        <Button
          onClick={handleStart}
          disableElevation
          variant="contained"
          color="secondary"
        >
          Start
        </Button>
      </div>
    </>
  );

  const GameMenu = () => (
    <>
      <Button
        color="primary"
        className={classes.button}
        onClick={() => setShowForm(true)}
      >
        New Game
      </Button>
      <Button color="primary" className={classes.button}>
        Multiplayer
      </Button>
      <Button color="primary" className={classes.button}>
        History
      </Button>
    </>
  );

  return (
    <Dialog classes={{ paper: classes.paper }} open={open}>
      {!showForm && <GameMenu />}
      {showForm && <Form />}
    </Dialog>
  );
};

export default Menu;
