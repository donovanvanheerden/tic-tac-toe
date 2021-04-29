import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';

const styles = ({ palette, spacing }: Theme) =>
  createStyles({
    paper: {
        display: 'flex',
        backgroundColor: "transparent",
        boxShadow: 'none',
        justifyContent: "center",
        alignItems: "center",
        padding: spacing(),
        height: spacing(24)
    },
    button: {
        width: 300,
        backgroundColor: palette.common.white,
        margin: spacing(),
        height: spacing(10),
        '&:hover': {
            backgroundColor: palette.primary.light,
            color: palette.primary.contrastText,
        }
    },
    textfield: {
        borderRadius: spacing(0.5),
        backgroundColor: palette.common.white,
        width: 600,
    },
    formActions: {
        display: 'flex',
        flexDirection: 'row',
        justifyContent: 'flex-end',
        width: "100%",
        padding: spacing(),
        '& button': {
            width: 100,
        },
        '& button:not(:first-child)': {
            marginLeft: spacing(),
        }
    }
  });

export default makeStyles(styles);
