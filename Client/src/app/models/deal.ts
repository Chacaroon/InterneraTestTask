import { Seller } from './seller';
import { Customer } from './customer';
import { Product } from './product';

export class Deal {

	public seller: Seller;
	public customer: Customer;
	public product: Product;

	public productAmount: number;
}
