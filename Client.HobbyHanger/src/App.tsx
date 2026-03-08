import { useEffect, useState } from "react";
import {List, ListItem, Typography} from "@mui/material";

function App() {
  const [clothes, setClothes] = useState<Clothe[]>([]);

  // () this just means a callback function inside the arguemnt, for useEffect
  useEffect(() => {
    fetch("https://localhost:5001/api/Clothes")
      .then(response => response.json())
        .then(data => setClothes(data))
  }, []);
  
  return (
      <>
        <Typography variant='h3'>Hobby Hanger</Typography>
        <List>
          {clothes.map((clothes) => (
              <ListItem key={clothes.id}>
                  <ListItemText>{clothes.name}</ListItemText>
              </ListItem>
          ))}
        </List>
      </>
  )
}

export default App