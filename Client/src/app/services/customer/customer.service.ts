import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Customer } from '../../models/customer';

@Injectable({
	providedIn: 'root'
})
export class CustomerService {

	constructor(private http: HttpClient) {
	}

	public getAll(): Observable<Customer[]> {
		return this.http.get<Customer[]>(`${environment.apiUrl}/Customer`);
	}
}
