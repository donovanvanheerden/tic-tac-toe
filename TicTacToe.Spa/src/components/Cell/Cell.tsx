import useStyles from "./Cell.styles";
import clsx from "clsx";

interface Props {
  id: number;
  value: string;
  onClick: () => void;
}

const Cell = ({ value = "", onClick }: Props) => {
  const classes = useStyles();

  const handleClick = () => {
    if (value) return;

    onClick();
  };

  const isCross = value === "X";

  const className = clsx([
    classes.root,
    { [classes.o]: !isCross },
    { [classes.x]: isCross },
  ]);

  return (
    <div className={className} onClick={handleClick}>
      {value}
    </div>
  );
};

export default Cell;
