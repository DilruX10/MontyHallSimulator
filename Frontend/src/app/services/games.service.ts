import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class GamesService {
  private urlGames = 'https://localhost:7159/MontyHall/';

  constructor(private httpClient: HttpClient) {}

  getGames(size: Number, changed: String) {
    return this.httpClient.get(this.urlGames + size + '/' + changed);
  }
}
