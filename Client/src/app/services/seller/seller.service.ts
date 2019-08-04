import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Seller } from '../../models/seller';
import { environment } from '../../../environments/environment';

@Injectable({
	providedIn: 'root'
})
export class SellerService {

	constructor(private http: HttpClient) {
	}

	public getAll(): Observable<Seller[]> {
		return this.http.get<Seller[]>(`${environment.apiUrl}/Seller`);
	}

}
