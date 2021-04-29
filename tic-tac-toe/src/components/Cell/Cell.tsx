import { useState } from "react";
import useStyles from "./Cell.styles";
import clsx from "clsx";
import useApi from "../../hooks/useApi";

interface Props {
  id: number;
}

const Cell = ({ id }: Props) => {
  const classes = useStyles();
  const { selectCell } = useApi();

  const [value, setValue] = useState<string | null>(null);

  const handleClick = () => {
    if (value) return;

    selectCell(id);
    setValue("X");
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
