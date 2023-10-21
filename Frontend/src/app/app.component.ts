import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { GamesService } from './services/games.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  games: any;
  form: FormGroup;
  size: number;
  changed: String;

  constructor(
    private formBuilder: FormBuilder,
    private service: GamesService
  ) {}

  ngOnInit() {
    this.form = this.formBuilder.group({
      size: 0,
      changeDoor: [null],
    });
  }

  // get list of games
  onSubmit() {
    // get values from the form
    this.size = this.form.get('size').value;
    this.changed = this.form.get('changeDoor').value;

    // send request
    this.service.getGames(this.size, this.changed).subscribe((response) => {
      this.games = response;
    });
  }
  title = 'Monty Python Simulator';
}
