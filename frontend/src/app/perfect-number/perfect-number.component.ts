import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { PerfectNumberService } from '../perfect-number.service';

@Component({
  selector: 'app-perfect-number',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './perfect-number.component.html',
  styleUrl: './perfect-number.component.css'
})
export class PerfectNumberComponent {
  feedback = 'Calculate the amount of perfect numbers!';

  service = inject(PerfectNumberService);

  boundsForm = new FormGroup({
    minimum: new FormControl(''),
    maximum: new FormControl(''),
  });

  submitPerfectNumberRequest() {
    const min = +(this.boundsForm.value.minimum ?? 0);
    const max = +(this.boundsForm.value.maximum ?? 0);
    this.service.getPerfectNumbersBetween(min, max).subscribe({
      next: perfectNumberCount => {
        this.feedback = "The amount of perfect numbers between "
          + `${min} and ${max} is ${perfectNumberCount.count}.`;
      },
      error: error => {
        this.feedback = `Invalid input: ${error.error}.`;
      },
    });
  }
}
