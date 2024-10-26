import { Injectable } from '@angular/core';
import { PerfectNumberCount } from './perfect-number-count';

@Injectable({
  providedIn: 'root'
})
export class PerfectNumberService {
  url = "http://localhost:8080/api/v1/perfectNumbers?";

  constructor() { }

  async getPerfectNumbersBetween(min: number, max: number): Promise<PerfectNumberCount> {
    const data = await fetch(this.url + new URLSearchParams({
      min: min.toString(),
      max: max.toString()
    }).toString());

    return (await data.json()) ?? { anzahlVollkommeneZahlen: 0 };
  }
}
