import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl } from '@angular/forms';
import { SellerService } from '../../services/seller/seller.service';
import { Seller } from '../../models/seller';

@Component({
	selector: 'app-sellers-dropdown',
	templateUrl: './sellers-dropdown.component.html',
	styleUrls: ['./sellers-dropdown.component.scss']
})
export class SellersDropdownComponent implements OnInit {

	@Input() control: AbstractControl;
	sellers: Array<Seller> = [];

	constructor(private sellerService: SellerService) {
	}

	ngOnInit() {
		this.sellerService.getAll().subscribe(sellers => this.sellers = sellers);
	}

}
