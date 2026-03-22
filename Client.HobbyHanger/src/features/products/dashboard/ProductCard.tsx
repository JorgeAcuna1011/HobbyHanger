import { Button, Card, CardActions, CardContent, Chip, Typography } from "@mui/material"

type Props = {
    product: Product
}

export default function ProductCard({product}: Props) {
    return (
        <Card sx={{borderRadius: 3}}>
            <CardContent>
                <Typography variant="h5">{product.Name}</Typography>
                <Typography sx={{color: 'text.secondary', mb: 1}}>{product.Price}</Typography>
            </CardContent>
            <CardActions sx={{display: 'felx', justifyContent: 'space-between', pb: 2}}>
                <Chip label={product.description} variant="outlined" />
                <Button size="medium" variant="contained">View</Button>
            </CardActions>
        </Card>
    )
}