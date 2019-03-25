import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class ServiceDataService {

  constructor(private _http: HttpClient) { }

  getOrders(pageIndex: number, pageSize: number) {
    return this._http.get('https://localhost:5001/api/order/' + pageIndex + '/' + pageSize)
      .pipe(map((res: any) => res.json()));
  }

  getOrdersByCustomer(n: number) {
    return this._http.get('https://localhost:5001/api/order/bycustomer/' + n)
      .pipe(map((res: any) => res.json()));
  }

  getOrdersByState() {
    return this._http.get('https://localhost:5001/api/order/bystate/')
      .pipe(map((res: any) => res.json()));
  }
}
