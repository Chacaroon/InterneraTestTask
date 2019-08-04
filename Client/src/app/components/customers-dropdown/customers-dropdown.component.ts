import { Component, Input, OnInit } from '@angular/core';
import { CustomerService } from '../../services/customer/customer.service';
import { Customer } from '../../models/customer';
import { AbstractControl } from '@angular/forms';

@Component({
	selector: 'app-customers-dropdown',
	templateUrl: './customers-dropdown.component.html',
	styleUrls: ['./customers-dropdown.component.scss']
})
export class CustomersDropdownComponent implements OnInit {

	@Input() control: AbstractControl;

	customers: Array<Customer>;

	constructor(private customerService: CustomerService) {
	}

	ngOnInit() {
		this.customerService.getAll().subscribe(customers => this.customers = customers);
	}

}
