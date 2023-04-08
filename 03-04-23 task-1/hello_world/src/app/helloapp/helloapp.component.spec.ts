import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelloappComponent } from './helloapp.component';

describe('HelloappComponent', () => {
  let component: HelloappComponent;
  let fixture: ComponentFixture<HelloappComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HelloappComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HelloappComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
