import { Component, OnInit } from '@angular/core';
import { Deal } from '../../models/deal';
import { DealService } from '../../services/deal/deal.service';

@Component({
	selector: 'app-deals',
	templateUrl: './deals.component.html',
	styleUrls: ['./deals.component.scss']
})
export class DealsComponent implements OnInit {

	deals: Deal[];

	constructor(private dealService: DealService) {
	}

	ngOnInit() {
		this.dealService.delas$.subscribe(deals => this.deals = deals);

		this.dealService.updateDealsList();
	}

}
