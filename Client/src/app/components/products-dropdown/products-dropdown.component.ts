import { AfterViewInit, Component, Input, OnInit } from '@angular/core';
import { ProductService } from '../../services/product/product.service';
import { AbstractControl, FormControl } from '@angular/forms';
import { Product } from '../../models/product';

@Component({
	selector: 'app-products-dropdown',
	templateUrl: './products-dropdown.component.html',
	styleUrls: ['./products-dropdown.component.scss']
})
export class ProductsDropdownComponent implements OnInit {

	@Input() control: AbstractControl;

	products: Array<Product> = [{name: 'Select a product', id: null}];

	constructor(private productService: ProductService) {
	}

	ngOnInit() {
		this.productService.getAll()
			.subscribe(products => this.products = products);
	}

}
