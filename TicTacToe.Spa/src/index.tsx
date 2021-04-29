import { createMuiTheme, ThemeProvider } from "@material-ui/core";
import ReactDOM from "react-dom";
import App from "./App";
import "./index.css";

const theme = createMuiTheme({
  palette: {
    primary: {
      main: "#16a085",
    },
    secondary: {
      main: "#2980b9",
    },
  },
});

ReactDOM.render(
  <ThemeProvider theme={theme}>
    <App />
  </ThemeProvider>,
  document.getElementById("root")
);
