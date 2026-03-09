import { useEffect, useState } from "react";
import axios from "axios";
import { Typography, List, ListItem, ListItemText } from "@mui/material";

function App() {
    const [clothes, setClothes] = useState<Clothes[]>([]);

    useEffect(() => {
        axios.get<Clothes>("https://localhost:5001/api/Clothes")
            .then(response => setClothes(response.data));
    }, []);

    return (
        <>
            <Typography variant="h3">Hobby Hanger</Typography>
            <List component="ul">
                {clothes.map((item) => (
                    <ListItem key={item.productId}>
                        <ListItemText primary={item.name} />
                    </ListItem>
                ))}
            </List>
        </>
    );
}

export default App;