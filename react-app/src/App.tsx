import { useState } from "react";
import Alert from "./components/Alert";
import Button from "./components/Button";

function App() {
  const [alertVisible, setAlertVisibilety] = useState(false);

  return (
    <div>
      {alertVisible && (
        <Alert onClose={() => setAlertVisibilety(false)}>yo</Alert>
      )}

      <Button onClick={() => setAlertVisibilety(true)}>click me</Button>
    </div>
  );
}

export default App;
