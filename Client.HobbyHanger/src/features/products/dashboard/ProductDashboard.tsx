import { Grid, List, ListItem, ListItemText } from "@mui/material";

type Props = {
    products: Product[];
}
export default function ProductDashboard({products}: Props){
    return (
        <Grid container>
            <Grid size={9}>
                <List component="ul">
                    {products.map((product) => (
                        <ListItem key={product.productId}>
                            <ListItemText primary={product.name} />
                        </ListItem>
                    ))}
                </List>
            </Grid>
        </Grid>
    )
}