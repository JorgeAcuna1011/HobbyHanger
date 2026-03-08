import { ClothesCategory, ClothesSize, Conditions, Gender } from "./enum"

type Clothes = {
    id: string;
    name: string;
    description: string;
    price: number;
    brand?: string;
    category: ClothingCategory;
    clothingSize?: ClothingSize;
    waistSize?: number;
    condition: Conditions;
    gender:  Gender;
    date: string;
    IsSold: boolean;
}