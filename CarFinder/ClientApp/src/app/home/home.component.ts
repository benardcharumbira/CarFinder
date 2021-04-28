import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {
private http: HttpClient;
private baseUrl: string;
public cars: any[];
public pageNumber: number = 1;
public count: number;

constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;

    http.get<PageResult>(baseUrl + 'api/car/getcars').subscribe(result => {
    this.cars = result.items;
    this.pageNumber = result.pageIndex;
    this.count = result.count;
    }, error => console.error(error));
}

public onPageChange = (pageNumber) => {
    this.http.get<PageResult>(this.baseUrl + 'api/car/getcars?page=' + pageNumber).subscribe(result => {
    this.cars = result.items;
    this.pageNumber = result.pageIndex;
    this.count = result.count;
    }, error => console.error(error));
}
}

interface Car {
  id: number;
  model: string;
  brand: string;
  isNew: boolean;
  color: string;
  mileage: string;
}

interface PageResult {
  count: number
  pageIndex: number;
  pageSize: number;
  items: Car[]
}

