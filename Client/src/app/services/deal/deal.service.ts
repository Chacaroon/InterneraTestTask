import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable, Subject } from 'rxjs';
import { Deal } from '../../models/deal';
import { AddDeal } from '../../models/addDeal';
import { Router } from '@angular/router';

@Injectable({
	providedIn: 'root'
})
export class DealService {

	private dealsSubject: Subject<Deal[]> = new Subject<Deal[]>();

	constructor(private http: HttpClient, private router: Router) {
	}

	public get delas$(): Observable<Deal[]> {
		return this.dealsSubject.asObservable();
	}

	public updateDealsList(): void {
		this.http.get<Deal[]>(`${environment.apiUrl}/Deal`)
			.subscribe(deal => this.dealsSubject.next(deal));
	}

	public addDeal(deal: AddDeal): void {
		this.http.post(`${environment.apiUrl}/Deal`, deal)
			.subscribe(() => {
				this.router.navigate(['']);
			});
	}
}
