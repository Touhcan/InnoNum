import { inject, Injectable } from '@angular/core';
import { PerfectNumberResponse } from './perfect-number-response';
import { PerfectNumberCount } from './perfect-number-count';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PerfectNumberService {
  url = "http://localhost:8080/api/v1/perfectNumber";

  http = inject(HttpClient);

  constructor() { }

  getPerfectNumbersBetween(min: number, max: number): Observable<PerfectNumberCount> {
    const url = this.url + new URLSearchParams({
      min: min.toString(),
      max: max.toString(),
    });

    return this.http.get<PerfectNumberResponse>(this.url, {
      params: { min: min, max: max },
    }).pipe(
      map(response => ({ count: response.anzahlVollkommeneZahlen }))
    );
  }
}
