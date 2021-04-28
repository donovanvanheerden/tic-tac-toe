import Cell from "./components/Cell/Cell";

const App = () => {
  const cells = new Array(9).fill(0).map((_, i) => ({ index: i, value: null }));

  return (
    <div
      style={{
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        maxWidth: 700,
        margin: "0 auto",
        flexWrap: "wrap",
      }}
    >
      {cells.map((c) => (
        <Cell key={c.index} />
      ))}
    </div>
  );
};

export default App;
