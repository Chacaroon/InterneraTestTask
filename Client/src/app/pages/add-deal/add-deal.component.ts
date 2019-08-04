import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DealService } from '../../services/deal/deal.service';

@Component({
	selector: 'app-add-deal',
	templateUrl: './add-deal.component.html',
	styleUrls: ['./add-deal.component.scss']
})
export class AddDealComponent implements OnInit {

	form: FormGroup;

	constructor(private fb: FormBuilder, private dealService: DealService) {
	}

	ngOnInit() {
		this.form = this.fb.group({
			productId: [null, Validators.required],
			sellerId: [null, Validators.required],
			customerId: [null, Validators.required],
			productAmount: [0, Validators.min(1)]
		});

	}

	submit() {
		if (this.form.invalid) {
			this.form.markAllAsTouched();
			return;
		}

		this.dealService.addDeal(this.form.value);
	}
}
