import { Box } from '@mui/material';


type Props = {
    products: Product[]
}

export default function ProductList({products}: Props) {
    return (
        <Box sx={{display: 'flex', flexDirection: 'column', gap: 3}}>
            {products.map(products => (
                
            ))}
        </Box>
        
        
    )
}