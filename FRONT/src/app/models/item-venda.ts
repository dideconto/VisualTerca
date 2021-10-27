import { Produto } from "./produto";

export interface ItemVenda {
    id?: number;
    produto: Produto;
    quantidade: number;
    preco: number;
    criadoEm?: Date;
}
