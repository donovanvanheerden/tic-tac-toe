import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';

const styles = ({ palette, spacing }: Theme) =>
  createStyles({
    root: {
        display: "flex",
        width: spacing(16),
        height: spacing(16),
        padding: spacing(2),
        backgroundColor: "#dfe6e94a",
        margin: spacing(0.5),
        borderRadius: spacing(0.5),
        justifyContent: "center",
        alignItems: "center",
        fontSize: "72pt",
        fontFamily: "Sans-Serif",
        cursor: "pointer",
        userSelect: "none",
    },
    x: {
        color: palette.primary.main,
    },
    o: {
     color: palette.secondary.main,
    }
  });

export default makeStyles(styles);
