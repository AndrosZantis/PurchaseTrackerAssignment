import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Purchase {
    id: number;
    name: string;
    purchasedAt: Date;
    quantity: number;
    unitPrice: number;
    description?: string;
    totalCost: number;
}

@Injectable({
  providedIn: 'root'
})
export class PurchaseService {
    private apiUrl = 'http://localhost:5170/api/purchase';

    constructor(private http: HttpClient) { }


    
    public getPurchases(): Observable<Purchase[]> {
        return this.http.get<Purchase[]>(this.apiUrl);
    }

    public getPurchase(id: number): Observable<Purchase> {
        return this.http.get<Purchase>(`${this.apiUrl}/${id}`);
    }
}
