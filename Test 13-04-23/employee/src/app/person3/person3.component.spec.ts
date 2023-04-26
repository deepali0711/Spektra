import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Person3Component } from './person3.component';

describe('Person3Component', () => {
  let component: Person3Component;
  let fixture: ComponentFixture<Person3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Person3Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Person3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
