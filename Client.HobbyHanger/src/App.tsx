import { useEffect, useState } from "react";
import { Typography, List, ListItem, ListItemText } from "@mui/material";

function App() {
    const [clothes, setClothes] = useState<any[]>([]);

    useEffect(() => {
        fetch("https://localhost:5001/api/Clothes")
            .then((response) => response.json())
            .then((data) => setClothes(data));
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