import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';

const styles = ({ spacing }: Theme) =>
  createStyles({
    root: {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        maxWidth: 600,
        margin: "0 auto",
        flexWrap: "wrap",
        padding: spacing(),
    },
  });

export default makeStyles(styles);
